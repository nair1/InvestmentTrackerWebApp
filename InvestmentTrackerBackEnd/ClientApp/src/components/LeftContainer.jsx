import React from "react";
import { makeStyles } from "@mui/styles";
import AlertDialog from "./login/AlertDialog";

function LeftContainer() {
  const classes = useStyles();

  return (
    <div className={classes.leftContainer}>
      <AlertDialog />
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
