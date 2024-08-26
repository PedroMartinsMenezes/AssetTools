namespace AssetTool
{
    [JsonAsset("AnimDataModel")]
    public class UAnimDataModel : UObject
    {
        public const string TypeName = "AnimDataModel";

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
