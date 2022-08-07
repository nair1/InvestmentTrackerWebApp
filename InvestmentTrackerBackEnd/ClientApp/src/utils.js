export function sendLoginRequest(username, password) {
    fetch("api/Login/Login", {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({ username: username, password: password }),
        })
        .then((response) => response.text())
        .then((text) => console.log(text));
}