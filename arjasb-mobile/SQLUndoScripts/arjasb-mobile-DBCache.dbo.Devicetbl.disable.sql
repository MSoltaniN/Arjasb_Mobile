IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Devicetbl]')) 
   ALTER TABLE [dbo].[Devicetbl] 
   DISABLE  CHANGE_TRACKING
GO
