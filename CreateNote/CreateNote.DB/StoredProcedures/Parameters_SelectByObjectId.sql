﻿--CREATE DEFINER=`bb3b063a6a284c`@`%` PROCEDURE `Parameters_SelectByObjectId`(in id int)
--BEGIN
--select o.id, o.name, o.surface,pm.id,pm.Rz,pm.Ra,pm.Rmax,pm.Image,tc.id,tc.comments
--from heroku_c31bbe938c6a3f9.testingcase tc
--join heroku_c31bbe938c6a3f9.object o on o.id = tc.ObjectID
--join heroku_c31bbe938c6a3f9.Parameters pm on pm.id = tc.ParametersID
--where o.id = id;
--END
