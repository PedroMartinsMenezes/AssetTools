namespace AssetTool
{
    [JsonAsset("TextureFactory")]
    public class UTextureFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UDIMTextureFunctionLibrary")]
    public class UUDIMTextureFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}