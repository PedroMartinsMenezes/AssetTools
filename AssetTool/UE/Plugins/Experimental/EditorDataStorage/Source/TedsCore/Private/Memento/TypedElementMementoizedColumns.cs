namespace AssetTool
{
    [JsonAsset("TedsSelectionColumnMementoTranslator")]
    public class UTedsSelectionColumnMementoTranslator : UTedsDefaultMementoTranslator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}