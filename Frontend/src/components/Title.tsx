import React from "react";

export const Title = ({ children }) => (
  <h1
    style={{ marginBottom: "1rem" }}
    className="text-white text-3xl text-justify ml-20 mt-14 font-bold uppercase  "
  >
    {children}
  </h1>
);
