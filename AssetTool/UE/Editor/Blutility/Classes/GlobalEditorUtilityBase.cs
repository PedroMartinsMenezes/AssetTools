namespace AssetTool
{
    [JsonAsset("DEPRECATED_GlobalEditorUtilityBase")]
    public class UDEPRECATED_GlobalEditorUtilityBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}