namespace AssetTool
{
    [JsonAsset("DatasmithSceneActor")]
    public class ADatasmithSceneActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}