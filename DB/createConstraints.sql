ALTER TABLE Party ADD
CONSTRAINT FK_Party_PartyType FOREIGN KEY (partyTypeid) REFERENCES PartyType(id)
,CONSTRAINT FK_Party_PartyStatus FOREIGN KEY (partyStatusId) REFERENCES PartyStatus(id)
,CONSTRAINT FK_Party_FloorTable FOREIGN KEY (floorTableId) REFERENCES FloorTable(id)


ALTER TABLE PartyTableLog ADD
CONSTRAINT FK_PartyTableLog_Party FOREIGN KEY (partyId) REFERENCES Party(id)
,CONSTRAINT FK_PartyTableLog_FloorTable FOREIGN KEY (tableId) REFERENCES FloorTable(id)
,CONSTRAINT FK_PartyTableLog_TableStatusID FOREIGN KEY (tableStatusId) REFERENCES TableStatus(id)


ALTER TABLE FloorTable ADD
CONSTRAINT FK_FloorTable_Party FOREIGN KEY (partyId) REFERENCES Party(id)
,CONSTRAINT FK_FloorTable_TableStatus FOREIGN KEY (tableStatusId) REFERENCES TableStatus(id)

