USE [Project_1_Pos_FakeData]
GO
/****** Object:  Trigger [dbo].[trg_DelOrder]    Script Date: 2020-11-13 7:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[trg_DelOrder] on [dbo].[CacBanCoDon]
after delete as
begin
	update dbo.BanAn set isOrder = 0 where id in (select d.id_ban from deleted as d)
end
GO
ALTER trigger [dbo].[trg_AddNewOrder] on [dbo].[CacBanCoDon]
after insert, update as
begin
	if (select isOrder from BanAn where id = (select i.id_ban from inserted as i)) = 0
		update dbo.BanAn set isOrder = 1 where id = (select i.id_ban from inserted as i)
end
GO
ALTER trigger [dbo].[trg_DelArea] on [dbo].[KhuVuc]
after delete as
begin
	delete from dbo.BanAn where id_khuVuc = (select d.id from deleted as d)
end
GO
ALTER trigger [dbo].[trg_DelProduct] on [dbo].[SanPham]
after delete as
begin
	delete from [dbo].[Lam] where id_sanPham = (select d.id_sp from deleted as d)
end
