IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Defecttbl]')) 
   ALTER TABLE [dbo].[Defecttbl] 
   ENABLE  CHANGE_TRACKING
GO
