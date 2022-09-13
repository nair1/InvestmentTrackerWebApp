import { React, useState } from "react";
import { makeStyles } from "@mui/styles";
import LoginPopup from "./login/LoginPopup";
import Portfolio from "./portfolio/Portfolio";

function MainContainer() {
  const classes = useStyles();

  const [loginMode, setLoginMode] = useState("");

  return (
    <div className={classes.mainContainer}>
      <LoginPopup loginMode={loginMode} setLoginMode={setLoginMode} />
      <Portfolio></Portfolio>
    </div>
  );
}

const useStyles = makeStyles({
  mainContainer: {
    backgroundColor: "#ffc8c8",
    height: "100vh",
    width: "100vw",
    display: "flex",
  },
});

export default MainContainer;
