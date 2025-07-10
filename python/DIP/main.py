from email_service import EmailService
from email_client_low_level_module import GmailClient

gmailClient = GmailClient()
emailService = EmailService(gmailClient)
emailService.sendWelcomeEmail(
    "mail@sarvesh.xyz", "Sarvesh")
