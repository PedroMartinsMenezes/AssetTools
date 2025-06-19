namespace AssetTool
{
    [JsonAsset("LevelInstancePivot")]
    public class ALevelInstancePivot : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}