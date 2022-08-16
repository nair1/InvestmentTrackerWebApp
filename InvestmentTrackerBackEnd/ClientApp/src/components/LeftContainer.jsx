import { React, useState } from "react";
import { makeStyles } from "@mui/styles";
import LoginPopup from "./login/LoginPopup";

function LeftContainer() {
  const classes = useStyles();

  const [loginMode, setLoginMode] = useState("");

  return (
    <div className={classes.leftContainer}>
      <LoginPopup loginMode={loginMode} setLoginMode={setLoginMode} />
    </div>
  );
}

const useStyles = makeStyles({
  leftContainer: {
    backgroundColor: "#ffc8c8",
    width: "50%",
    height: "100%",
    textAlign: "left",
  },
});

export default LeftContainer;
