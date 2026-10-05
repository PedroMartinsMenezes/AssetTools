namespace AssetTool
{
    [Location("Inspired by https://github.com/atenfyr/UAssetAPI")]
    public class FileVersion
    {
        public EUnrealEngineObjectUE4Version FileVersionUE4 { get; set; }
        public EUnrealEngineObjectUE5Version FileVersionUE5 { get; set; }
        public List<FileCustomVersion> CustomVersions { get; set; }

        public class FileCustomVersion
        {
            public string Name { get; set; }
            public Guid Key { get; set; }
            public int Version { get; set; }
        }

        public List<FCustomVersion> GetCustomVersions()
        {
            return CustomVersions.Select(cv => new FCustomVersion
            {
                Key = new FGuid(cv.Key),
                Version = cv.Version,
            })
            .ToList();
        }
    }
}
