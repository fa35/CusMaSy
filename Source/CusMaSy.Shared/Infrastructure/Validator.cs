﻿using CusMaSy.Shared.Models.Interfaces;
using System.Text.RegularExpressions;

namespace CusMaSy.Shared.Infrastructure
{
    public static class Validator
    {
        public static bool CheckMailadresse(string content)
        {
            if (!string.IsNullOrWhiteSpace(content) && content.Contains("@") && content.Contains("."))
                return true;
            return false;
        }

        public static bool CheckPLZ(string content)
        {
            int plz = 0;
            int.TryParse(content, out plz);

            if (plz > 0 && plz >= 1000)
                return true;
            return false;
        }

        public static bool CheckHomepage(string content)
        {
            if (content.Contains(".") && !content.Contains("|") && !content.Contains("´") && !content.Contains("`"))
                return true;
            return false;
        }

        public static bool CheckAnbieterTyp(string content)
        {
            if (content.ToLower().Equals("kaufmann") || content.ToLower().Equals("privatperson"))
                return true;

            return false;
        }

        public static bool CheckStringIsLong(string content)
        {
            long number = 0;
            long.TryParse(content, out number);

            if (number > 0)
                return true;

            return false;
        }

        public static bool CheckAnbieterNrExists(long anbieterNr, IFachkonzept fachkonzept)
        {
            var anbieter = fachkonzept.FindAnbieterByNr(anbieterNr);

            if (anbieter == null)
                return false;
            return true;
        }

        public static bool CheckLand(string content)
        {
            var regex = new Regex(@"^-?\d+$");

            if (!string.IsNullOrWhiteSpace(content) && regex.IsMatch(content))
                return true;

            return false;
        }
    }
}
