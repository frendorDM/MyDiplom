﻿--CREATE DEFINER=`bb3b063a6a284c`@`%` PROCEDURE `CountSuccessfulTesting_SelectByObjectId`(in id int)
--BEGIN
--Select o.id,o.Name, count(tc.Comments) 
--from heroku_c31bbe938c6a3f9.testingcase tc
--join heroku_c31bbe938c6a3f9.object o on o.id = tc.ObjectID
--where tc.comments = 'Поверхность соответствует заявленной' and o.id = id;
--END
