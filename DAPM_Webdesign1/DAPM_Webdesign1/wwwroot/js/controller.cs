namespace DAPM_Webdesign1.wwwroot.js
{
    public class controller
    {
        document.getElementById('loginForm').addEventListener('submit', function(event) {
  event.preventDefault();
  const username = document.getElementById('loginUsername').value;
        const password = document.getElementById('loginPassword').value;

        // Simuliere den Aufruf an den Backend-Server zur Überprüfung des Logins
        login(username, password);
    });

document.getElementById('registerForm').addEventListener('submit', function(event)
    {
  event.preventDefault();
        const username = document.getElementById('registerUsername').value;
        const password = document.getElementById('registerPassword').value;

        // Simuliere den Aufruf an den Backend-Server zur Registrierung des Benutzers
        register(username, password);
    });

function login(username, password)
    {
        // Implementiere die Logik für den Login hier
        // Du würdest normalerweise eine AJAX-Anfrage an den Server senden
        // und die Antwort verarbeiten, um den Benutzer einzuloggen.
        console.log('Login Request - Username:', username, 'Password:', password);
    }

    function register(username, password)
    {
        // Implementiere die Logik für die Registrierung hier
        // Du würdest normalerweise eine AJAX-Anfrage an den Server senden
        // und die Antwort verarbeiten, um den Benutzer zu registrieren.
        console.log('Register Request - Username:', username, 'Password:', password);
    }
}
}
