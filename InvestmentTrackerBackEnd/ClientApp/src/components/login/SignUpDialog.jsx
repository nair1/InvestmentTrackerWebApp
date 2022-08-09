import { React, useState } from "react";
import { makeStyles } from "@mui/styles";
import Button from "@mui/material/Button";
import Dialog from "@mui/material/Dialog";
import DialogActions from "@mui/material/DialogActions";
import DialogContent from "@mui/material/DialogContent";
import DialogTitle from "@mui/material/DialogTitle";
import TextField from "@mui/material/TextField";
import IconButton from "@mui/material/IconButton";
import CloseIcon from "@mui/icons-material/Close";
import { sendLoginRequest } from "../../utils.js";

export default function SignUpDialog(props) {
  const [userInfo, setUserInfo] = useState({
    firstName: "",
    lastName: "",
    email: "",
    password: "",
  });

  const classes = useStyles();

  const handleLogin = () => {
    sendLoginRequest(username.text, password.text);
    props.handleClose();
  };

  return (
    <div>
      <Dialog
        open={props.open}
        onClose={props.handleClose}
        aria-labelledby="alert-dialog-title"
        aria-describedby="alert-dialog-description"
      >
        <DialogTitle id="alert-dialog-title" className={classes.dialogTitle}>
          {"Investment Tracker Signup"}
          <IconButton onClick={props.handleClose}>
            <CloseIcon />
          </IconButton>
        </DialogTitle>

        <DialogContent className={classes.loginFieldsContainer}>
          <TextField
            className={classes.loginField}
            id="outlined-required"
            label="First Name"
          />
          <TextField
            className={classes.loginField}
            id="outlined-required"
            label="Last Name"
          />
          <TextField
            className={classes.loginField}
            id="outlined-required"
            label="Email"
          />
          <TextField
            className={classes.loginField}
            id="outlined-required"
            label="Username"
          />
          <TextField
            className={classes.loginField}
            id="outlined-password-input"
            label="Password"
            type="password"
            autoComplete="current-password"
          />
        </DialogContent>
        <DialogActions className={classes.dialogActions}>
          <Button
            className={classes.buttons}
            variant="contained"
            onClick={handleLogin}
            autoFocus
          >
            Sign Up
          </Button>
        </DialogActions>
      </Dialog>
    </div>
  );
}

const useStyles = makeStyles({
  alertDialog: {
    marginTop: "15px",
    marginLeft: "15px",
  },
  loginFieldsContainer: {
    display: "flex",
    flexDirection: "column",
    width: "500px",
  },
  loginField: {
    margin: "6px !important",
  },
  dialogActions: {
    padding: "16px 24px !important",
    justifyContent: "flex-end",
    display: "flex",
    flexDirection: "column",
  },
  buttons: {
    width: "100%",
    margin: "2px 0px !important",
  },
  dialogTitle: {
    display: "flex",
    justifyContent: "space-between",
    alignItems: "center",
  },
});
