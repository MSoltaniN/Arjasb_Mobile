IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[ownertbl]')) 
   ALTER TABLE [dbo].[ownertbl] 
   ENABLE  CHANGE_TRACKING
GO
