IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[ordertbl]')) 
   ALTER TABLE [dbo].[ordertbl] 
   DISABLE  CHANGE_TRACKING
GO
