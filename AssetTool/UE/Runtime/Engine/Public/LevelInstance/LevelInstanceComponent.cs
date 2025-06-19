namespace AssetTool
{
    [JsonAsset("LevelInstanceComponent")]
    public class ULevelInstanceComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}