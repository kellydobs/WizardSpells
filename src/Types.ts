import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./App";

export type SpellType = {
  id: number | undefined;
  name: string;
  action: string;
  description: string;
  comments: CommentType[];
};

export type APIError = {
  errors: Record<string, string[]>;
  status: number;
  title: string;
  traceId: string;
  type: string;
};

export type CommentType = {
  id: number | undefined;
  comment: string;
  createdAt: Date;
  spellId: number;
};
