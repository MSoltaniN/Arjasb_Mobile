IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Defecttbl]')) 
   ALTER TABLE [dbo].[Defecttbl] 
   DISABLE  CHANGE_TRACKING
GO
