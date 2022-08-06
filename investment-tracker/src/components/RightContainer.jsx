import React from "react";
import { makeStyles } from "@mui/styles";

function RightContainer() {
  const classes = useStyles();

  return <div className={classes.rightContainer}></div>;
}

const useStyles = makeStyles({
  rightContainer: {
    backgroundColor: "blue",
    width: "50%",
    height: "100%",
  },
});

export default RightContainer;
