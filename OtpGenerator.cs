using System;

namespace OtpGenerator
{
    public static class OtpGenerator
    {
        public static string GenerateOTP(int otpLength)
        {
            //const int otpLength = 6; // Length of the OTP

            // Generate a random OTP using a random number generator
            var random = new Random();
            var otp = string.Empty;

            for (int i = 0; i < otpLength; i++)
            {
                otp += random.Next(0, 9); // Generate a random digit (0-9)
            }

            return otp;
        }
    }
}
