import { React, useState } from "react";
import { makeStyles } from "@mui/styles";
import Button from "@mui/material/Button";
import LoginDialog from "./LoginDialog.jsx";
import SignUpDialog from "./SignUpDialog.jsx";

export default function LoginPopup(props) {
  const classes = useStyles();

  const [loginDialogOpen, setLoginDialogOpen] = useState(false);
  const [signupDialogOpen, setSignupDialogOpen] = useState(false);

  const handleLoginDialogOpen = () => {
    setLoginDialogOpen(true);
  };

  const handleLoginDialogClose = () => {
    setLoginDialogOpen(false);
  };

  const handleSignupDialogOpen = () => {
    setSignupDialogOpen(true);
  };

  const handleSignupDialogClose = () => {
    setSignupDialogOpen(false);
  };

  const switchLoginToSignup = () => {
    setLoginDialogOpen(false);
    setSignupDialogOpen(true);
  };

  return (
    <div className={classes.alertDialog}>
      <Button variant="contained" onClick={handleLoginDialogOpen}>
        Log in
      </Button>
      <LoginDialog
        open={loginDialogOpen}
        setOpen={setLoginDialogOpen}
        handleClose={handleLoginDialogClose}
        switchLoginWindow={switchLoginToSignup}
      />
      <SignUpDialog
        open={signupDialogOpen}
        setOpen={setLoginDialogOpen}
        handleClose={handleSignupDialogClose}
      />
    </div>
  );
}

const useStyles = makeStyles({
  alertDialog: {
    marginTop: "15px",
    marginLeft: "15px",
  },
});
