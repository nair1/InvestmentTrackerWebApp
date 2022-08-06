import * as React from "react";
import { makeStyles } from "@mui/styles";
import Button from "@mui/material/Button";
import Dialog from "@mui/material/Dialog";
import DialogActions from "@mui/material/DialogActions";
import DialogContent from "@mui/material/DialogContent";
import DialogTitle from "@mui/material/DialogTitle";
import TextField from "@mui/material/TextField";

export default function AlertDialog() {
  const [open, setOpen] = React.useState(false);

  const classes = useStyles();

  const handleClickOpen = () => {
    setOpen(true);
  };

  const handleClose = () => {
    setOpen(false);
  };

  return (
    <div className={classes.alertDialog}>
      <Button variant="contained" onClick={handleClickOpen}>
        Log in
      </Button>
      <Dialog
        open={open}
        onClose={handleClose}
        aria-labelledby="alert-dialog-title"
        aria-describedby="alert-dialog-description"
      >
        <DialogTitle id="alert-dialog-title">
          {"Investment Tracker Login"}
        </DialogTitle>
        <DialogContent className={classes.loginFieldsContainer}>
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
        <DialogActions>
          <Button onClick={handleClose}>Cancel</Button>
          <Button variant="contained" onClick={handleClose} autoFocus>
            Login
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
});
