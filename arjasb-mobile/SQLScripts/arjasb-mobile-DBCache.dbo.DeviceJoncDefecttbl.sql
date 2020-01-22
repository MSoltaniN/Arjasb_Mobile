IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[DeviceJoncDefecttbl]')) 
   ALTER TABLE [dbo].[DeviceJoncDefecttbl] 
   ENABLE  CHANGE_TRACKING
GO
