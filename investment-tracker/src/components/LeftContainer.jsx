import React from "react";
import { makeStyles } from "@mui/styles";

function LeftContainer() {
  const classes = useStyles();

  return <div className={classes.leftContainer}></div>;
}

const useStyles = makeStyles({
  leftContainer: {
    backgroundColor: "red",
    width: "50%",
    height: "100%",
  },
});

export default LeftContainer;
