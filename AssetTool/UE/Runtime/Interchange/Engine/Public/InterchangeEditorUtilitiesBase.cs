namespace AssetTool
{
    [JsonAsset("InterchangeEditorUtilitiesBase")]
    public class UInterchangeEditorUtilitiesBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}