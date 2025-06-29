namespace AssetTool
{
    [JsonAsset("CurveTable")]
    public class UCurveTable : UObject
    {
        public ECurveTableMode CurveTableMode;
        public int CurveRowCount;
        public List<CurveRow> CurveRows;

        [Location("void UCurveTable::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref CurveRowCount);

            if (!transfer.Supports.ShrinkCurveTableSize)
                CurveTableMode = CurveRowCount > 0 ? ECurveTableMode.RichCurves : ECurveTableMode.Empty;
            else
                CurveTableMode = (ECurveTableMode)transfer.Move((byte)CurveTableMode);

            transfer.Move(ref CurveRows, CurveRowCount, (x) => x.Move(transfer, CurveTableMode));

            return this;
        }

        public class CurveRow : ITransferible<ECurveTableMode>
        {
            public FName RowName;
            public UScriptStruct ScriptStruct;

            public ITransferible Move(Transfer transfer, ECurveTableMode CurveTableMode)
            {
                transfer.Move(ref RowName);
                transfer.Move(ref ScriptStruct, (x) => x.SerializeTaggedProperties(transfer));
                return this;
            }

            public ITransferible Move(Transfer transfer)
            {
                throw new NotImplementedException();
            }
        }

        public enum ECurveTableMode : byte
        {
            Empty,
            SimpleCurves,
            RichCurves
        }
    }
}
