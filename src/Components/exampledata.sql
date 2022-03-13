
CREATE TABLE "User" (
  "Id" SERIAL PRIMARY KEY,
  "UserName" TEXT,
  "Password" TEXT,
  "Avatar" IMAGE,
);
-- username is email address
-- INSERT INTO "Users" ("UserName", "Password", "Avatar") VALUES ('EleanorM@wizardmail.com','LemonDrop','Hufflepuff');


CREATE TABLE "Spell" (
  "Id" SERIAL PRIMARY KEY,
  "Name" TEXT,
  "Wand Movement" TEXT,
  "Description" TEXT,
  "Completed" BOOL
  
);

-- INSERT INTO "WizardSpells" ("Name", "Action", "Description" ) VALUES ('Wingardium Leviosa', 'The Quidditch balls will levitate.', 'To make a target levitate.');



CREATE TABLE "Comments" (
 "ID"				SERIAL Primary Key,
 "UserName" 		TEXT NOT NULL,
 "Comment"			TEXT NOT NULL,
 "Spell"			TEXT NOT NULL,
 "Time"				TIMESTAMP
 ); 
  
  -- INSERT INTO "Comments" ("UserName", "Comment", "Spell", "Date") VALUES ('KellyD@wizardmail.com','Point down towards the sensor','Arresto Momentum', '2021-11-28');