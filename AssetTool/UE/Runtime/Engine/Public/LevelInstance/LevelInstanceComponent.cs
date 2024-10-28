namespace AssetTool
{
    [JsonAsset("LevelInstanceComponent")]
    public class ULevelInstanceComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}