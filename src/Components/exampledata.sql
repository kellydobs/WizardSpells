
CREATE TABLE "User" (
  "Id" SERIAL PRIMARY KEY,
  "Name" TEXT,
  "Password" TEXT,
  "Avatar" IMAGE,
);



CREATE TABLE "Spell" (
  "Id" SERIAL PRIMARY KEY,
  "Name" TEXT,
  "Wand Movement" TEXT,
  "Description" TEXT,
  "Completed" BOOL
  
);


CREATE TABLE "Comments" (
  
  "UserName" TEXT,
  "Comment" TEXT,
  "Spell", TEXT,
  "Time", TIMESTAMP
);
/* what is primary id here?