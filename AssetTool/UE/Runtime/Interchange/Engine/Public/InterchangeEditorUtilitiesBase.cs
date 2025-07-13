namespace AssetTool
{
    [JsonAsset("InterchangeEditorUtilitiesBase")]
    public class UInterchangeEditorUtilitiesBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}