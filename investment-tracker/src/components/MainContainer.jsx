import React from "react";
import { makeStyles } from "@mui/styles";
import LeftContainer from "./LeftContainer";
import RightContainer from "./RightContainer";

function MainContainer() {
  const classes = useStyles();

  return (
    <div className={classes.mainContainer}>
      <LeftContainer />
      <RightContainer />
    </div>
  );
}

const useStyles = makeStyles({
  mainContainer: {
    backgroundColor: "green",
    height: "100vh",
    width: "100vw",
    display: "flex",
    flexDirection: "row",
  },
});

export default MainContainer;
