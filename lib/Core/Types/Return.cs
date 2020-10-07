using System;
using System.Collections.Generic;

namespace Core.Types
{
	public class Return<T>
	{
		public T Value
			=> GetValueOrDefault()
			?? throw new InvalidOperationException();

		public T GetValueOrDefault(T defaultValue)
			=> this is Success success
				? success.Value
				: defaultValue;

		public T GetValueOrDefault()
			=> GetValueOrDefault(default);

		public Error[] Errors
			=> this is Failure failure
				? failure.Errors
				: new Error[0];

		public bool HasValue => this is Success;

		public static implicit operator Return<T>(T value)
			=> new Success(value);

		public static explicit operator T(Return<T> ret)
			=> ret.Value;

		public static implicit operator Return(Return<T> ret)
			=> ret;

		public static implicit operator Return<T>(Error error)
			=> new Failure(error);

		public static implicit operator Return<T>(Error[] errors)
			=> new Failure(errors);

		public static implicit operator Return<T>(List<Error> errors)
			=> new Failure(errors.ToArray());

		private class Failure : Return<T>
		{
			public Failure(params Error[] errors)
			{
				Errors = errors;
			}

			public new Error[] Errors { get; }
		}

		private class Success : Return<T>
		{
			public Success(T value)
			{
				Value = value;
			}

			public new T Value { get; }
		}
	}

	public class Return : Return<object>
	{
		public static implicit operator Return(Error error)
			=> error;
	}
}
