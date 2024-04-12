"""ExtAPIError exception class."""


class ExtAPIError(Exception):
    """Exception class for external API errors."""

    def __init__(
        self,
        status_code: int,
        message: str = 'Falha ao carregar da API',
    ) -> None:
        """Initialize the class."""
        self.message = message
        self.status_code = status_code
        super().__init__(self.message)

    def to_dict(self) -> dict:
        """Return the exception as a dictionary."""
        return {
            'message': self.message,
            'status_code': self.status_code,
        }
