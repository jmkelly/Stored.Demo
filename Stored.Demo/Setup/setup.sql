create database store;
create user store_user  with password 'my super secret password';
GRANT ALL PRIVILEGES ON DATABASE store TO store_user;
GRANT ALL PRIVILEGES ON DATABASE store TO store_user;

--log into the store database
CREATE EXTENSION IF NOT EXISTS "uuid-ossp" SCHEMA public;


