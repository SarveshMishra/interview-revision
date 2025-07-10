from email_client  import EmailClient


class EmailService:

    def __init__(self, emailClient: EmailClient):
        self.emailClient = emailClient

    def sendWelcomeEmail(self,user_email:str, user_name: str):
        subject = f"Welcome {user_name}"
        body = "Thanks for signing up to our awesome platform. We're glad to have you!"
        self.emailClient.sendEmail(user_email, subject, body)
