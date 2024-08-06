namespace InventoryManagement.Model;

public class TrackingNumber
{
    public string Prefix { get;  }
    public string MainNumber { get;  }
    public string Suffix { get;  }
    
    public TrackingNumber(string prefix, string mainNumber, string suffix)
    {
        if (string.IsNullOrWhiteSpace(mainNumber))
        {
            throw new ArgumentException("Main number cannot be empty or whitespace.");
        }

        Prefix = prefix?.Trim() ?? string.Empty;
        MainNumber = mainNumber.Trim();
        Suffix = suffix?.Trim() ?? string.Empty;
    }

    public static TrackingNumber Parse(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Tracking Number cannot be empty or whitespace.");
        }

        var segments = value.Split("-");
        switch (segments.Length)
        {
            case 1:
                return new TrackingNumber(null, segments[0], null);
            case 2:
                return new TrackingNumber(segments[0], segments[1], null);
            case 3:
                return new TrackingNumber(segments[0], segments[1], segments[2]);
            default:
                throw new FormatException("Invalid Tracking Number format.");
        }
    }

    public override string ToString() => $"{Prefix}-{MainNumber}-{Suffix}".Trim('-');
}