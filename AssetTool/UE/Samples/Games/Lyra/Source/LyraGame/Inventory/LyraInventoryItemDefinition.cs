namespace AssetTool
{
    [JsonAsset("LyraInventoryItemFragment")]
    public class ULyraInventoryItemFragment : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraInventoryItemDefinition")]
    public class ULyraInventoryItemDefinition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraInventoryFunctionLibrary")]
    public class ULyraInventoryFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}