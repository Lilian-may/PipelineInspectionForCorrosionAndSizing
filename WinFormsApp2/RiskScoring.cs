namespace WinFormsApp2
{
    public static class RiskScoring
    {
        public static (string severity, int riskScore) Evaluate(decimal depthPct, decimal lengthMm, decimal widthMm)
        {
            int score = 0;

            if (depthPct < 10) score += 5;
            else if (depthPct < 20) score += 15;
            else if (depthPct < 40) score += 30;
            else score += 50;

            if (lengthMm < 50) score += 5;
            else if (lengthMm < 200) score += 15;
            else score += 30;

            if (widthMm < 30) score += 5;
            else if (widthMm < 100) score += 10;
            else score += 20;

            string sev = score switch
            {
                < 30 => "Low",
                < 60 => "Medium",
                < 80 => "High",
                _ => "Critical"
            };

            return (sev, score);
        }
    }
}
