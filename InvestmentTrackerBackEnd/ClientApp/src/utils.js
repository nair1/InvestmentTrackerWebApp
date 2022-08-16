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

export function sendSignupRequest(userInfo) {
    fetch("api/Login/Signup", {
            method: "POST",
            headers: {
                "Content-Type": "Application/json",
            },
            body: JSON.stringify(userInfo),
        })
        .then(response => response.text())
        .then(text => console.log(text));
}