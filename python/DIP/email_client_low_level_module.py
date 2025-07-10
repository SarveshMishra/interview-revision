from email_client import EmailClient

class GmailClient(EmailClient):
    '''
    Gmail Client to send email
    '''

    def __init__(self):
        super().__init__()

    def sendEmail(self, to, subject, body):
        isEmailSent = False
        print(f"Sending email using Gmail Client to {to}, {subject},{body} ")

        print("Email Sent")
        isEmailSent = True
        return isEmailSent


class OutLookClient(EmailClient):
    '''
    Gmail Client to send email
    '''

    def __init__(self):
        super().__init__()

    def sendEmail(to, subject, body):
        isEmailSent = False
        print(f"Sending email using Gmail Client to {to}, {subject},{body} ")

        print("Email Sent")
        isEmailSent = True
        return isEmailSent
