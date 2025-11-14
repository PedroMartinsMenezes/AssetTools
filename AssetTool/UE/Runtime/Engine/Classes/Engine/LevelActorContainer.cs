namespace AssetTool
{
    [JsonAsset("LevelActorContainer")]
    public class ULevelActorContainer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}