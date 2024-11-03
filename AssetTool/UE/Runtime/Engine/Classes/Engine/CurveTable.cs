namespace AssetTool
{
    [JsonAsset("CurveTable")]
    public class UCurveTable : UObject
    {
        public ECurveTableMode CurveTableMode;
        public List<CurveRow> CurveRows = [];

        [Location("void UCurveTable::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            CurveRows.Resize(transfer);

            int NumRows = CurveRows.Count;

            if (!Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.ShrinkCurveTableSize))
                CurveTableMode = NumRows > 0 ? ECurveTableMode.RichCurves : ECurveTableMode.Empty;
            else
                CurveTableMode = (ECurveTableMode)transfer.Move((byte)CurveTableMode);

            CurveRows.ForEach(x => x.Move(transfer, CurveTableMode));

            return this;
        }

        public class CurveRow
        {
            public FName RowName;
            public UScriptStruct scriptStruct = new();

            public CurveRow Move(Transfer transfer, ECurveTableMode CurveTableMode)
            {
                transfer.Move(ref RowName);
                scriptStruct.SerializeTaggedProperties(transfer);
                return this;
            }
        }

        public enum ECurveTableMode : byte
        {
            Empty,
            SimpleCurves,
            RichCurves
        };
    }
}
