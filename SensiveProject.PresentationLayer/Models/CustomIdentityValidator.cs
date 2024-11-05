using Microsoft.AspNetCore.Identity;

namespace SensiveProject.PresentationLayer.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = "Parola minimum 6 karakterden oluşmalı"
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Parola en az 1 küçük karakter içermeli"
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Parola en az 1 büyük karakter içermeli"
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Parola en az 1 sembol içermeli"
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = "Parola en az 1 rakam içermeli"
			};
		}
	}
}
