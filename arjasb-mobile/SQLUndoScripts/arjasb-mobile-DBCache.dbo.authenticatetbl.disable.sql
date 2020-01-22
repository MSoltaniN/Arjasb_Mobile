IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[authenticatetbl]')) 
   ALTER TABLE [dbo].[authenticatetbl] 
   DISABLE  CHANGE_TRACKING
GO
