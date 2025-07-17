namespace AssetTool
{
    [JsonAsset("LyraAbilityCost")]
    public class ULyraAbilityCost : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}