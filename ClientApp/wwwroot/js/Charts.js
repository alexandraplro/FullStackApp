window.salesCharts = {
    renderRevenueChart: function (labels, data) {
        const ctx = document.getElementById('revenueChart').getContext('2d');

        if (window.revenueChartInstance) {
            window.revenueChartInstance.destroy();
        }

        window.revenueChartInstance = new Chart(ctx, {
            type: 'line',
            data: {
                labels: labels,
                datasets: [{
                    label: 'Revenue',
                    data: data,
                    borderColor: '#4e79a7',
                    backgroundColor: 'rgba(78, 121, 167, 0.2)',
                    tension: 0.3
                }],
                options: {
                    plugins: {
                        tooltip: {
                            callbacks: {
                                label: function(context) {
                                    const value = context.raw;
                                        return 'Revenue: $' + value.toLocaleString();
                                }
                            }
                        }
                    }
                }
            }
        });
    },

    renderUnitsChart: function (labels, data) {
        const ctx = document.getElementById('unitsChart').getContext('2d');

        if (window.unitsChartInstance) {
            window.unitsChartInstance.destroy();
        }

        window.unitsChartInstance = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: labels,
                datasets: [{
                    label: 'Units Sold',
                    data: data,
                    backgroundColor: '#59a14f'
                }],
                options: {
                    plugins: {
                        tooltip: {
                            callbacks: {
                                label: function(context) {
                                    const value = context.raw;
                                    return value + ' units';
                                }
                            }
                        }
                    }
                }
            }      

        });
    }
};
