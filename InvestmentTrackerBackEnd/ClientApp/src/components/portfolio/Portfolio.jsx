import { React, useState } from "react";
import { makeStyles } from "@mui/styles";
import { sendInvestmentRequest } from "../../utils.js";
import Button from "@mui/material/Button";

export default function Portfolio(props) {
  const classes = useStyles();

  const [investments, setInvestments] = useState("");

  const handleGetInvestments = () => {
    setInvestments(sendInvestmentRequest("sachin1118"));
  };

  return (
    <div className={classes.portfolio}>
      <Button onClick={handleGetInvestments}>Get Investments</Button>
      {investments}
    </div>
  );
}

const useStyles = makeStyles({
  portfolio: {},
});
