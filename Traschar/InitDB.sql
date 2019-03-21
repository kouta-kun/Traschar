create database tscr;
use tscr;
create table users (
 username varchar(100) primary key,
 password varchar(100) not null
 );

create table chatgroup (
 groupid integer auto_increment primary key,
 name varchar(100) not null
);

create table isInGroup (
 userId varchar(100) not null,
 groupid integer not null,
 foreign key (userId) references users(username),
 foreign key (groupid) references chatgroup(groupid),
 primary key (userId, groupid)
);

create table messages (
 groupid integer not null,
 userid varchar(100) not null,
 messageid integer auto_increment primary key,
 message varchar(100) not null,
 foreign key (groupid) references chatgroup(groupid),
 foreign key (userid) references users(username)
);