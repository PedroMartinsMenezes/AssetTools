namespace AssetTool
{
    [JsonAsset("SoundSubmixFactory")]
    public class USoundSubmixFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundfieldSubmixFactory")]
    public class USoundfieldSubmixFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EndpointSubmixFactory")]
    public class UEndpointSubmixFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundfieldEndpointSubmixFactory")]
    public class USoundfieldEndpointSubmixFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}