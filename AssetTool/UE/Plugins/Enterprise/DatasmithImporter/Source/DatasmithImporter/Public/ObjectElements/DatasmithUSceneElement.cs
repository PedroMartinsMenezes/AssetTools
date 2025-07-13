namespace AssetTool
{
    [JsonAsset("DatasmithSceneElementBase")]
    public class UDatasmithSceneElementBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}