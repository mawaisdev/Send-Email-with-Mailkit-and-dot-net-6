﻿namespace SimpleEmailApp.Services.EmailService
{
    public interface IEmailService
    {
        void SendMail(EmailDto request);
    }
}
