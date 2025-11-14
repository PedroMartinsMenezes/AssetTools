namespace AssetTool
{
    [JsonAsset("GlobalEditorUtilityBase")]
    public class UDEPRECATED_GlobalEditorUtilityBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}